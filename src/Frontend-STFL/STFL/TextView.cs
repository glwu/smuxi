// Smuxi - Smart MUltipleXed Irc
// 
// Copyright (c) 2011 Mirco Bauer
// 
// Full GPL License: <http://www.gnu.org/licenses/gpl.txt>
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307 USA

using System;
using System.Collections.Generic;

namespace Stfl
{
    public class TextView : Widget
    {
        public string OffsetVariableName { get; set; }
        public bool AutoLineWrap { get; set; }
        List<string> Lines { get; set; }
        int WrappedLineCount { get; set; }

        public int Offset {
            get {
                return Int32.Parse(Form[OffsetVariableName]);
            }
            set {
                var minOffset = OffsetStart;
                var maxOffset = OffsetEnd;
                if (value > maxOffset) {
                    value = maxOffset;
                } else if (value < minOffset) {
                    value = minOffset;
                }
                Form[OffsetVariableName] = value.ToString();
            }
        }

        public int OffsetStart {
            get {
                return 0;
            }
        }

        public int OffsetEnd {
            get {
                int heigth = Heigth;
                if (WrappedLineCount <= heigth) {
                    return 0;
                }
                return WrappedLineCount - heigth;
            }
        }

        public TextView(Form form, string widgetId) :
                   base(form, widgetId)
        {
            Lines = new List<string>();
            Form.EventReceived += OnEventReceived;
        }

        public void AppendWrappedLine(string line)
        {
            WrappedLineCount++;
            Form.Modify(
                WidgetName,
                "append",
                "{" +
                    "listitem text:" + StflApi.stfl_quote(line) +
                "}"
            );
        }

        public void AppendWrappedLines(IEnumerable<string> lines)
        {
            // FIXME: do one append instead
            foreach (var line in lines) {
                WrappedLineCount++;
                Form.Modify(
                    WidgetName,
                    "append",
                    "{" +
                        "listitem text:" + StflApi.stfl_quote(line) +
                    "}"
                );
            }
        }

        public void AppendLine(string line)
        {
            var width = Width;
            if (!AutoLineWrap || width <= 0) {
                // we don't know our width for whatever reason thus we can't
                // apply any line wrapping
                Lines.Add(line);
                AppendWrappedLine(line);
                return;
            }

            Lines.Add(line);
            foreach (var wrappedLine in WrapLine(line, width)) {
                AppendWrappedLine(wrappedLine);
            }
        }

        public void AppendLines(IEnumerable<string> lines)
        {
            var width = Width;
            if (!AutoLineWrap || width <= 0) {
                // we don't know our width for whatever reason thus we can't
                // apply any line wrapping
                Lines.AddRange(lines);
                AppendWrappedLines(lines);
                return;
            }

            Lines.AddRange(lines);
            foreach (var line in lines) {
                foreach (var wrappedLine in WrapLine(line, width)) {
                    AppendWrappedLine(wrappedLine);
                }
            }
        }

        public void ScrollUp()
        {
            Scroll(-0.9);
        }

        public void ScrollDown()
        {
            Scroll(0.9);
        }

        protected void Scroll(double scrollFactor)
        {
            int currentOffset = Offset;
            int newOffset = (int) (currentOffset + (Heigth * scrollFactor));
            if (newOffset < 0) {
                newOffset = 0;
            } else if (newOffset > OffsetEnd) {
                newOffset = OffsetEnd;
            }
            Offset = newOffset;
        }

        public void ScrollToStart()
        {
            Offset = OffsetStart;
        }

        public void ScrollToEnd()
        {
            Offset = OffsetEnd;
        }

        public void Clear()
        {
            Lines.Clear();
            WrappedLineCount = 0;
            Form.Modify(WidgetName, "replace_inner", "{list}");
            ScrollToStart();
        }

        public static List<string> WrapLine(string line, int wrapWidth)
        {
            if (line == null) {
                throw new ArgumentNullException("line");
            }
            if (wrapWidth <= 0) {
                throw new ArgumentException("Wrap width must bigger than 0",
                                            "wrapWidth");
            }

            var wrappedLine = new List<string>();
            if (line.Length <= wrapWidth) {
                wrappedLine.Add(line);
                return wrappedLine;
            }

            var tags = new List<string>();
            for (int i = 0; i < line.Length; i += wrapWidth) {
                var chunkSize = Math.Min(line.Length - i, wrapWidth);
                // FIXME: don't break style tags
                // TODO: word wrapping
                var chunk = line.Substring(i, chunkSize);
                wrappedLine.Add(chunk);
            }

            return wrappedLine;
        }

        void Resize()
        {
            if (!AutoLineWrap || Width <= 0) {
                // nothing to do
                return;
            }

            // re-add all lines
            var offset = Offset;
            var lines = new List<string>(Lines);
            Clear();
            AppendLines(lines);
            Offset = offset;
        }

        void OnEventReceived(object sender, EventReceivedEventArgs e)
        {
            if (e.Event == "RESIZE") {
                Resize();
            }
        }
    }
}

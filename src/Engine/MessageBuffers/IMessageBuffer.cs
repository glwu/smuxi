// Smuxi - Smart MUltipleXed Irc
//
// Copyright (c) 2010-2011 Mirco Bauer <meebey@meebey.net>
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

namespace Smuxi.Engine
{
    public interface IMessageBuffer : IEnumerable<MessageModel>, IDisposable
    {
        int                 Count { get; }
        int                 MaxCapacity { get; set; }
        MessageModel        this[long timestamp, int counter] { get; set; }
        void                Add(MessageModel msg);
        IList<MessageModel> GetRange(int offset, int limit);
        IEnumerable<MessageModel> GetNextMessages(long timestamp, int counter, int limit);
        IEnumerable<MessageModel> GetPreviousMessages(long timestamp, int counter, int limit);
        void                Flush();
        void                Clear();
    }
}

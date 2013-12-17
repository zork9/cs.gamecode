/*
 Copyright (C) Johan Ceuppens 2013

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 2 of the License, or
 (at your option) any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace Game2
{
namespace Room
{
using Coord;

	public class Room {
		Room(int xx, int yy, int relxx, int relyy) { map = new Map(xx,yy,relxx,relyy); }

		public moveLeft() { map.moveLeft(); }
		public moveRight() { map.moveRight(); }
		public moveDown() { map.moveDown(); }
		public moveUp() { map.moveUp(); }
	
		private Map map;
	};
};
};	

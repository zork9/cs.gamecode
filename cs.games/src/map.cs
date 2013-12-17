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
namespace Map 
{
using Coord;

	public class Map {
		Map(int xx, int yy, int relxx, int relyy) { 
			_mapcoord = new Coord(xx,yy); 
			_maprelativecoord = new Coord(relxx,relyy); 
		}

		private Coord _mapcoord;
		private Coord _maprelativecoord;

	};
};
};	

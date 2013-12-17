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
namespace Stimlib 
{
using Coord;
using Image;

	public class Stimlib {
		Stimlib() {
			index = 0; 
		}

		private int index;

		public void addImage(Image img) {
			images.add(img);
		} 

		public void getImage() {
			images.get(index);
		} 

		public void getImageNext() {
			images.get(index++);
		} 

		public void getImageWithIndex(int idx) {
			images.get(idx);
		} 

		private List<Image> images;
	};
};
};	

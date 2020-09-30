//    Copyright (C) 2020 Ned Makes Games

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with this program. If not, see <https://www.gnu.org/licenses/>.

using Unity.Mathematics;
using UnityEngine;

public class Zoomer : MonoBehaviour {
    [SerializeField] private float period = 0;
    [SerializeField] private float2 range = 0;
    [SerializeField] private Transform handle = null;

    private void Update() {
        float z = math.lerp(range.x, range.y, (math.sin(Time.timeSinceLevelLoad * math.PI / period) + 1) / 2f);
        handle.localPosition = new Vector3(0, 0, z);
    }
}

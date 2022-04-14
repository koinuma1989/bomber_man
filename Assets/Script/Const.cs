using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Const
{
    public static Vector3[] hardBlock = new Vector3[]{
		//外ブロック
		new Vector3(14f , 0f, 14f),
		new Vector3(12f , 0f, 14f),
		new Vector3(10f , 0f, 14f),
		new Vector3(8f , 0f, 14f),
		new Vector3(6f , 0f, 14f),
		new Vector3(4f , 0f, 14f),
		new Vector3(2f , 0f, 14f),
		new Vector3(0f , 0f, 14f),
		new Vector3(-2f , 0f, 14f),
		new Vector3(-4f , 0f, 14f),
		new Vector3(-6f , 0f, 14f),
		new Vector3(-8f , 0f, 14f),
		new Vector3(-10f , 0f, 14f),
		new Vector3(-12f , 0f, 14f),
		new Vector3(-14f , 0f, 14f),
		new Vector3(-14f , 0f, 12f),
		new Vector3(-14f , 0f, 10f),
		new Vector3(-14f , 0f, 8f),
		new Vector3(-14f , 0f, 6f),
		new Vector3(-14f , 0f, 4f),
		new Vector3(-14f , 0f, 2f),
		new Vector3(-14f , 0f, 0f),
		new Vector3(-14f , 0f, -2f),
		new Vector3(-14f , 0f, -4f),
		new Vector3(-14f , 0f, -6f),
		new Vector3(-14f , 0f, -8f),
		new Vector3(-14f , 0f, -10f),
		new Vector3(-14f , 0f, -12f),
		new Vector3(-14f , 0f, -14f),
		new Vector3(-12f , 0f, -14f),
		new Vector3(-10f , 0f, -14f),
		new Vector3(-8f , 0f, -14f),
		new Vector3(-6f , 0f, -14f),
		new Vector3(-4f , 0f, -14f),
		new Vector3(-2f , 0f, -14f),
		new Vector3(0f , 0f, -14f),
		new Vector3(2f , 0f, -14f),
		new Vector3(4f , 0f, -14f),
		new Vector3(6f , 0f, -14f),
		new Vector3(8f , 0f, -14f),
		new Vector3(10f , 0f, -14f),
		new Vector3(12f , 0f, -14f),
		new Vector3(14f , 0f, -14f),
		new Vector3(14f , 0f, -12f),
		new Vector3(14f , 0f, -10f),
		new Vector3(14f , 0f, -8f),
		new Vector3(14f , 0f, -6f),
		new Vector3(14f , 0f, -4f),
		new Vector3(14f , 0f, -2f),
		new Vector3(14f , 0f, 0f),
		new Vector3(14f , 0f, 2f),
		new Vector3(14f , 0f, 4f),
		new Vector3(14f , 0f, 6f),
		new Vector3(14f , 0f, 8f),
		new Vector3(14f , 0f, 10f),
		new Vector3(14f , 0f, 12f),

		//中のブロック位置
		new Vector3(10f , 0f, 10f),
		new Vector3(6f , 0f, 10f),
		new Vector3(2f , 0f, 10f),
		new Vector3(-2f , 0f, 10f),
		new Vector3(-6f , 0f, 10f),
		new Vector3(-10f , 0f, 10f),
		new Vector3(10f , 0f, 6f),
		new Vector3(6f , 0f, 6f),
		new Vector3(2f , 0f, 6f),
		new Vector3(-2f , 0f, 6f),
		new Vector3(-6f , 0f, 6f),
		new Vector3(-10f , 0f, 6f),
		new Vector3(10f , 0f, 2f),
		new Vector3(6f , 0f, 2f),
		new Vector3(2f , 0f, 2f),
		new Vector3(-2f , 0f, 2f),
		new Vector3(-6f , 0f, 2f),
		new Vector3(-10f , 0f, 2f),
		new Vector3(10f , 0f, -2f),
		new Vector3(6f , 0f, -2f),
		new Vector3(2f , 0f, -2f),
		new Vector3(-2f , 0f, -2f),
		new Vector3(-6f , 0f, -2f),
		new Vector3(-10f , 0f, -2f),
		new Vector3(10f , 0f, -6f),
		new Vector3(6f , 0f, -6f),
		new Vector3(2f , 0f, -6f),
		new Vector3(-2f , 0f, -6f),
		new Vector3(-6f , 0f, -6f),
		new Vector3(-10f , 0f, -6f),
		new Vector3(10f , 0f, -10f),
		new Vector3(6f , 0f, -10f),
		new Vector3(2f , 0f, -10f),
		new Vector3(-2f , 0f, -10f),
		new Vector3(-6f , 0f, -10f),
		new Vector3(-10f , 0f, -10f)
	};

	// softblockの位置
    // public static List<Vector3> softBlock = new List<Vector3>();
	// softBlock.Add(new Vector3(0f , 0f, 4f));

	public static List<Vector3> softBlock = new List<Vector3>(){
		new Vector3(0, 0, 4)
	};

}

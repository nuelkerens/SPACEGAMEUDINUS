using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTonSample{
	private volatile static SingleTonSample SingleTonObject;
	public static SingleTonSample InstanceCreation()
	{
		object lockingObject = new object();
		if (SingleTonObject == null )
		{
			lock (lockingObject)
			{
				if(SingleTonObject == null)
				{
					SingleTonObject = new SingleTonSample();
				}
			}
		}
		return SingleTonObject;
	}

	public void DisplayMessage()
	{
		Debug.Log("Kelas Singleton!");
	}
}

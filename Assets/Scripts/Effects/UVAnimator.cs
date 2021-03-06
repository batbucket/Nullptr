﻿using UnityEngine;
using System.Collections;

public class UVAnimator : MonoBehaviour {
	
		public int materialIndex = 0;
		public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
		public string textureName = "_MainTex";
		
		Vector2 uvOffset = Vector2.zero;
		void LateUpdate() 
		{
			uvOffset += ( uvAnimationRate * Time.deltaTime );
			if( this.GetComponent<Renderer>().enabled )
			{
				this.GetComponent<Renderer>().materials[ materialIndex ].SetTextureOffset( textureName, uvOffset );
			}
		}
		
		

}

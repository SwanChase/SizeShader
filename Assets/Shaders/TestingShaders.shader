// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader ".Unsure/TestingShaders"
{
	Properties
	{
		_MainTex("Main Texture", 2D) = "White" {}
		_Color("Main Color", Color) = (1,1,1,1)

		_ExtrudeAmount("Extrude Amount", Range(-1, 1)) = -0.005
	}
		SubShader
	{
		Pass
		{
		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag

		#include "UnityCG.cginc"

		struct appdata
		{
			float4 vertex : POSITION;
			float3 normal : NORMAL;
			float2 uv : TEXCOORD0;
		};

		struct v2f
		{
			float4 pos : SV_POSITION;
			float2 uv : TEXCOORD0;
		};

		uniform float4 _Color;
		uniform sampler2D _MainTex;

		float _ExtrudeAmount;

		v2f vert(appdata IN)
		{
			v2f OUT;
			IN.vertex.xyz += IN.normal.xyz * _ExtrudeAmount;

			OUT.pos = mul(UNITY_MATRIX_MVP, IN.vertex);
			OUT.uv = IN.uv;
			return OUT;
		}

		fixed4 frag(v2f IN) : SV_Target
		{
			float4 textureColor = tex2D(_MainTex, IN.uv);

			return textureColor * _Color;
		}

		ENDCG
		}
	}
}
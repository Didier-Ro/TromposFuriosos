Shader "Rim/Color"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
    }
    SubShader
    {

        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;
        float4 _Color;

        struct Input
        {
            float3 viewDir;
        };
        
        void surf (Input IN, inout SurfaceOutput o)
        {
            half dotp = 1 - saturate(dot(IN.viewDir, o.Normal));
            o.Emission = _Color * dotp;
            o.Albedo.rgb = 0;
        }
        ENDCG
    }
}

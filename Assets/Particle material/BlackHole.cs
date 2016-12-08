using UnityEngine;
using System.Collections;

public class BlackHole : MonoBehaviour
{
	public Material m_Mat = null;
	[Range(0.01f, 0.2f)] protected float m_DarkRange = 0.1f;
	[Range(-2.5f, -1f)] protected float m_Distortion = -2f;
	[Range(0.05f, 0.3f)] public float m_Form = 0.2f;
//	private float m_MouseX = 0f;
//	private float m_MouseY = 0f;
//	private bool m_TraceMouse = false;
    private Vector2 vec;


    void Start()
    {
        if (!SystemInfo.supportsImageEffects)
            enabled = false;

//        m_MouseX = m_MouseY = 0.5f;
        m_DarkRange = 0.03f;
        m_Distortion = -1.7f;
        vec.x = .72f;
        vec.y = .62f;

    }

    void OnRenderImage (RenderTexture sourceTexture, RenderTexture destTexture)
	{
		m_Mat.SetVector ("_Center", new Vector4 (vec.x , vec.y, 0f, 0f));
		m_Mat.SetFloat ("_DarkRange", m_DarkRange);
		m_Mat.SetFloat ("_Distortion", m_Distortion);
		m_Mat.SetFloat ("_Form", m_Form);
		Graphics.Blit (sourceTexture, destTexture, m_Mat);
	}

	void Update ()
	{
        // For testing positioning of the black hole //
	
        /*	if (Input.GetMouseButtonDown (1))
		{
			m_TraceMouse = true;
		}
		else if (Input.GetMouseButtonUp (1))
		{
			m_TraceMouse = false;
		}
		else if (Input.GetMouseButton (1))
		{
			if (m_TraceMouse)
			{
				m_MouseX = Input.mousePosition.x / Screen.width;
#if UNITY_5
				m_MouseY = 1f - Input.mousePosition.y / Screen.height;
#else
				m_MouseY = Input.mousePosition.y / Screen.height;
#endif
                Debug.Log(m_MouseY);
			}
		}*/
	}
    
}
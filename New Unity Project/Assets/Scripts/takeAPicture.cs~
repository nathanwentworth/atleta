using UnityEngine;
using System.Collections;

public class takeAPicture : MonoBehaviour {
		public WebCamTexture mCamera = null;
		public GameObject plane;

		private string frontCamName;
		private string backCamName;

	/// <summary>
	/// Meta reference to the camera
	/// </summary>
	public Material CameraMaterial = null;

	/// <summary>
	/// The number of frames per second
	/// </summary>
	private int m_framesPerSecond = 0;

	/// <summary>
	/// The current frame count
	/// </summary>
	private int m_frameCount = 0;

	/// <summary>
	/// The frames timer
	/// </summary>

	/// <summary>
	/// The selected device index
	/// </summary>
	private int m_indexDevice = -1;

		// Use this for initialization
		void Start ()
		{
			Debug.Log ("Script has been started");
			plane = GameObject.FindWithTag ("Player");

		WebCamDevice[] devices = WebCamTexture.devices;
		WebCamTexture webcamTexture = new WebCamTexture();
		WebCamTexture frontTex = new WebCamTexture();
		WebCamTexture backTex = new WebCamTexture();



		for (int i = 0; devices.Length > i; i++) {
			if (devices[i].isFrontFacing) {
				frontCamName = devices [i].name;
			}
			else {
				backCamName = devices [i].name;
			}
			frontTex = new WebCamTexture (frontCamName, 1280, 720, 30);
			backTex = new WebCamTexture (backCamName, 1280, 720, 30);
			frontTex.Play();
			Debug.Log (backCamName + " " + frontCamName);
		}

		plane.GetComponent<Renderer>().material.mainTexture = frontTex;
		frontTex.Play ();

		}

		// Update is called once per frame
		void Update ()
		{

		}
	}
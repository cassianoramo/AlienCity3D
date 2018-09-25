using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : NetworkBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;
	public Text Vitori;
	public Text Portao;
	public GameObject posCamera;
	public GameObject Cam1;
	public Material Mater;
	public GameObject Malha;

	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
		if (!isLocalPlayer) {
			return;
		}
var MinhaCam = (GameObject)Instantiate(Cam1, posCamera.transform.localPosition, posCamera.transform.localRotation);
		var eu = gameObject.transform;
		NetworkServer.Spawn (Cam1);
		MinhaCam.transform.parent = eu;
		MinhaCam.transform.localPosition = posCamera.transform.position;
		MinhaCam.transform.localRotation = posCamera.transform.rotation;

	}

	void Update()
	{
		if (!isLocalPlayer) {
			return;
		}
        Camera.main.transform.position = posCamera.transform.position;
		Camera.main.transform.rotation = posCamera.transform.rotation;

		Vector3 move = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		transform.Rotate (new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
		
		if (!cc.isGrounded) {
			gravidade += Physics.gravity * Time.deltaTime;
		} 
		else 
		{
			gravidade = Vector3.zero;
			if(jump)
			{
				gravidade.y = 6f;
				jump = false;
			}
		}
		move += gravidade;
		cc.Move (move* Time.deltaTime);
		Anima ();
	}
	 
	void Anima()
	{
		if (!Input.anyKey)
		{
			anim.SetTrigger("Parado");
		} 
		else 
		{
			if(Input.GetKeyDown("space"))
			{
				anim.SetTrigger("Pula");
				jump = true;
			}
			else
			{
				anim.SetTrigger("Corre");
			}
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Vitoria")) {
			Vitori.gameObject.SetActive (true);
			Portao.gameObject.SetActive (false);
		}
	}
	public override void OnStartLocalPlayer(){
		Malha.GetComponent<Renderer>().sharedMaterial = Mater;

	}
}

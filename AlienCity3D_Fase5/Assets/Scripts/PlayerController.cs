using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;
	public Text Vitori;
	public Text Portao;
	public int startvida = 10;
	public float vida;
	public HUDController Energia;
	int contcoracao = 0;
	public GameObject Heart;
	public GameObject Heart1;
	public GameObject Heart2;
	int countgem = 0;
	public Text gema;

	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
		vida = startvida;
		contcoracao = GameObject.FindGameObjectsWithTag ("Vida").Length;

		gema.text = "" + countgem;
	}

     void Update()
	{
		Energia.Vida (startvida, vida);
		gema.text = "" + countgem;
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
		if (vida == 0 && contcoracao == 1) {
			string currentScene = SceneManager.GetActiveScene ().name;
			SceneManager.LoadScene (currentScene);
		}
		if (vida == 0) {
			contcoracao--;
			if (contcoracao == 3) {
				Heart2.SetActive (false);
			}
			if (contcoracao == 2) {
				Heart1.SetActive (false);
			}
			if (contcoracao == 1) {
				Heart.SetActive (false);
			}
			vida = 10;
		}
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
		if (other.gameObject.CompareTag ("Obstaculo")) {
			vida -= 5;
		}
		if (other.gameObject.CompareTag ("pedra")) {
			countgem++;
		}
	}
}

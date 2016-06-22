using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
//GIT
public class Pergunta : MonoBehaviour {
	public Text pergunta;
	public Text b1;
	public Text b2;
	public Text b3;
	//  public Text n;

	public int idPergunta;
	public string questoes;
	public int respA;
	public int respB;
	public int respC;
	public int certa;
	public List<Pergunta> perguntas;

	public int nivel;
	private Moeda din;
	public int tenta;

	public bool proxima;

	public static float velocidade; //velocidade do movimento do objeto

	public GameObject g1;
	public GameObject g2;
	public GameObject g3;

	public Galinha galinha1;
	public Galinha galinha2;
	public Galinha galinha3;

	private int pontosOperacao;
	private string operacaoAtual;

	public Pergunta(string quest,int rA, int rB, int rC, int correta, int niv)
	{
		questoes = quest;
		respA = rA;
		respB = rB;
		respC = rC;
		certa = correta;
		nivel = niv;
	}


	void Start () {
		din = FindObjectOfType (typeof(Moeda)) as Moeda;
		//verdicia se tem moedas salvas - se tem atualiza



		perguntas = new List<Pergunta>();

		idPergunta = 0;
		operacaoAtual = "+";
		tenta = 3;
		pontosOperacao = 0;
		//SOMA
		perguntas.Add(new Pergunta("5+4=?", 1, 9, 7, 9, 1));
		perguntas.Add(new Pergunta("3+2=?", 4, 1, 5, 5, 1));
		perguntas.Add(new Pergunta("1+1=?", 2, 0, 4, 2, 1));
		perguntas.Add(new Pergunta("7+3=?", 8, 5, 10, 10, 1));
		perguntas.Add(new Pergunta("1+2=?", 4, 3, 5, 3, 1));
		//SUBTRAÇÃO 
		perguntas.Add(new Pergunta("18-5=?", 11, 13, 3, 13, 1));
		perguntas.Add(new Pergunta("22-10=?", 12, 10, 14, 12, 1));
		perguntas.Add(new Pergunta("17-6=?", 11, 5, 10, 11, 1));
		perguntas.Add(new Pergunta("2-1=?", 4, 1, 6, 1, 1));
		perguntas.Add(new Pergunta("19-1=?", 15, 18, 14, 18, 1));
		//MULTIPLICAÇÃO
		perguntas.Add(new Pergunta("3*3=?",1,9,7,9,1));
		perguntas.Add(new Pergunta("5*1=?",4,1,5,5,1));
		perguntas.Add(new Pergunta("2*2=?",2,0,4,4,1));
		perguntas.Add(new Pergunta("4*2=?",8,0,4,8,1));
		perguntas.Add(new Pergunta("4*1=?",4,0,4,4,1));
		//DIVISÃO
		perguntas.Add(new Pergunta("18/2=?", 9, 1, 7, 9, 1));
		perguntas.Add(new Pergunta("15/3=?", 5, 1, 1, 5, 1));
		perguntas.Add(new Pergunta("4/2=?", 2, 0, 4, 2, 1));
		perguntas.Add(new Pergunta("5*2=?", 10, 5, 11, 10, 1));
		perguntas.Add(new Pergunta("18/6=?", 3, 1, 5, 3, 1));
		//MISTURADO
		perguntas.Add(new Pergunta("5+4=?", 9, 9, 7, 9, 1));
		perguntas.Add(new Pergunta("10-5=?", 5, 1, 5, 5, 1));
		perguntas.Add(new Pergunta("2*1=?", 2, 0, 4, 2, 1));
		perguntas.Add(new Pergunta("7+3=?", 10, 5, 10, 10, 1));
		perguntas.Add(new Pergunta("18/6=?", 3, 3, 5, 3, 1));



		this.pergunta.text = perguntas[idPergunta].questoes;
		this.b1.text = perguntas[idPergunta].respA + "";
		this.b2.text = perguntas[idPergunta].respB + "";
		this.b3.text = perguntas[idPergunta].respC + "";


		//posicao original -- -46 / 141 / 307


		galinha1 = new Galinha (g1, 200, 31 - 46.0f);
		galinha2 = new Galinha (g2, 250, 31+16f);
		galinha3 = new Galinha (g3, 300, 31+73f);
		velocidade = -1.08f;
		proxima = false;



	}

	public void trocaOperacao()
	{
		
		switch (operacaoAtual) {

		case "+":
			
			PlayerPrefs.SetInt ("estrelas1", calcularEstrelas ());
			operacaoAtual = "-";

			break;
		case "-":
			PlayerPrefs.SetInt ("estrelas2", calcularEstrelas ());
			operacaoAtual = "*";

			break;
		case "*":
			PlayerPrefs.SetInt ("estrelas3", calcularEstrelas ());
			operacaoAtual = "/";

			break;
		case "/":
			PlayerPrefs.SetInt ("estrelas4", calcularEstrelas ());
			operacaoAtual = "%";
		
			break;
		case "%":
			PlayerPrefs.SetInt ("estrelas5", calcularEstrelas ());
			operacaoAtual = null;
			//perguntas = misturado;

			break;

		default:
			break;
		}


	}

	void proximaPergunta()
	{

		idPergunta += 1;
		//verifica se é fim de jogo
		print(idPergunta);
		if (idPergunta>perguntas.Count-1) {
			print ("Fim de Jogo");
			proxima = false;
		} else {
			proxima = true;
			if (idPergunta % 5==0) 
			{
				trocaOperacao();
			}
			tenta = 3;
		}




	}

	public void exibeTitulo()
	{
		pergunta.text = perguntas[idPergunta].questoes;
	}


	public void verificaResposta(string alternativa)
	{
		//	bool certa = false;
		int valor = 1;
		switch (alternativa) {
		case "A": 
			if(perguntas[idPergunta].certa == perguntas[idPergunta].respA )
			{

				din.adicionaValor( valor * tenta);
				//grava o valor das moedas
				PlayerPrefs.SetInt("moedas", din.dinheiro);
				PlayerPrefs.Save();
				proximaPergunta();
				galinha1.setMovimento ("E");
				galinha2.setMovimento ("D");
				galinha3.setMovimento ("D");
				//	certa = true;

			}
			else
			{
				if(tenta != 1){
					tenta = tenta - 1;
				}
			}
			break;
		case "B":
			if(perguntas[idPergunta].certa == perguntas[idPergunta].respB)
			{
				din.adicionaValor(valor * tenta);
				PlayerPrefs.SetInt("moedas", din.dinheiro);
				PlayerPrefs.Save();

				proximaPergunta();
				//	certa = true;
				galinha1.setMovimento ("D");
				galinha2.setMovimento ("E");
				galinha3.setMovimento ("D");
				print(din.retornaValor());
			}
			else{
				if(tenta != 1){
					tenta = tenta - 1;
				}
			}
			break;
		case "C": 
			if(perguntas[idPergunta].certa == perguntas[idPergunta].respC)
			{
				din.adicionaValor(valor * tenta);
				PlayerPrefs.SetInt("moedas", din.dinheiro);
				PlayerPrefs.Save();

				proximaPergunta();
				//		certa = true;
				galinha1.setMovimento ("D");
				galinha2.setMovimento ("D");
				galinha3.setMovimento ("E");
				print(din.retornaValor());
			}else
			{
				if(tenta != 1){
					tenta = tenta - 1;
				}
			}
			break;
		}
		//return certa;
	}


	// Update is called once per frame
	void FixedUpdate () {

		galinha1.andarGalinha ();
		galinha2.andarGalinha ();
		galinha3.andarGalinha ();

		if (galinha1.parado && galinha2.parado && galinha3.parado && proxima) {

			this.pergunta.text = perguntas[idPergunta].questoes;
			this.b1.text = perguntas[idPergunta].respA + "";
			this.b2.text = perguntas[idPergunta].respB + "";
			this.b3.text = perguntas[idPergunta].respC + "";
			proxima = false;
			galinha1.setMovimento ("I");
			galinha2.setMovimento ("I");
			galinha3.setMovimento ("I");
		}

	}

	private int calcularEstrelas()
	{
		int estrelas;
		if (pontosOperacao.Equals (15)) {
			estrelas = 3;
		} else if (pontosOperacao > 11) {
			estrelas = 2;
		} else {
			estrelas = 1;
		}

		return estrelas;

	}

}
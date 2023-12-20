//This → atributo do abjeto atual

//math.pi //3,14
//math.random //aleatorio

//atribuiçao dentro do objeto (:), fora (=)

//objeto:
var aluno = {
  nome: "Joãozinho",
  nota: 8.0,
  matricula: 12345,
  frequencia: 0.9,

  aprovado() {
      if(this.nota >=6 && this.frequencia>=0.7){
          return "Aprovado";}
      else{
          return "Reprovado";}
  }
};

console.log(`O aluno ${aluno.nome} teve a nota ${aluno.nota} e foi ${aluno.aprovado()}`);

//adicionando atributos para o objeto ja criado
aluno.telefone = "(32)336585474";

console.log(aluno);

var texto = "Este é um texto";
console.log(texto.length);

//array: diferentes valores em uma unica variavel

var Joãozinho = {
  nome: "Joãozinho",
  nota: 8.0,
  matricula: 12345,
  frequencia: 0.9,
}

var Jorginho = {
  nome: "Jorginho",
  nota: 8.0,
  matricula: 12345,
  frequencia: 0.9,
}

var alunos = ['Joãozinho', 'Jorginho'];
console.log(alunos);
console.log(alunos[1]);

var Juquinha = {
  nome: "Juquinha",
  nota: 8.0,
  matricula: 12345,
  frequencia: 0.9,
}

//adicona um elemento ao objeto aluno
alunos.push('Juquinha');
console.log(alunos);

//console.log(alunos.pop()); //remove o ultimo

for (var i=0; i<alunos.length; i++){
  console.log(alunos[i]);
}

//this -> pega do objeto

var Mariana = {
  numero: 10,

  conta(){
    var letra='';

      for (var i=1; i<=this.numero; i++)
      {
        letra +=
          `Mariana conta ${i} \n`+
          `Mariana conta ${i}: `;

        for (var j=1; j<=i; j++)
        {
          letra +=`é ${j}, `;
        }

        letra +=`é! \n`;
        letra +=`Ana viva a Mariana, viva a Mariana \n\n`;
      };
    console.log(letra);
  }
}

Mariana.conta(); 

/*Com array: */
/* 
var Mariana = {
  numero: 10,

  conta(){
    var letra='';
    var contagem=[];

      for (var i=1; i<=this.numero; i++)
      {
        contagem.push(` é ${i} `);
        letra +=
          `Mariana conta ${i} \n`+
          `Mariana conta ${i}: ${contagem}, é! \n`;
        letra +=`Ana viva a Mariana, viva a Mariana \n\n`;
      };
      console.log(letra);
  }
}

Mariana.conta(); 
*/

var dados = [1,2,3,4,5,6];
for (var i=0; i<dados.length;i++)
{
  console.log(dados[i]);
}
/*Funcao de kalbeck > passada como parametro */

/*OU Utilizando a funcao de kalbeck (mesma coisa) */
dados.forEach(function(item) {
  console.log(item);
});

function imprimirItem(item){
  console.log(item);
}
dados.forEach(imprimirItem);

//var -> nao respeita (pega de fora da funcao)
//const(nao muda) e let -> respeita o escopo do bloco (filho acessa o escopo do pai)
//bloco-> {}


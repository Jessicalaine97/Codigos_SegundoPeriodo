var nome;
nome = "Juquinha"
// ou var nome="Juquinha"

console.log(nome);
let sobrenome = "Silva";
const idade = 30;
//const gasta menos memoria (nao pode ser reescrita)

//concatenando:
var nomeCompleto = nome + ' ' + sobrenome;
console.log(nomeCompleto);

//imprimindo tipo:
console.log(typeof nome);

//var nome="Lisa",
// sobrenome="Cuddy",
// idade=27;
//var Nome="Jessica";

//Hoisting (nao da erro): 
//console.log(nomeCompleto);
//var nomeCompleto="Maria Silva";

//exercicio Aula:
//var nome="Jessica";
//var idade=25;
//var comidaFavorita="Japonesa";
//var signo, altura, peso;

var pontos = 7;
var texto = nome + 'fez' + pontos + 'pontos.';
console.log(texto);

var variavel1 = 123;
var variavel2 = '4';
var total = variavel1 + variavel2;
console.log(total);
console.log(typeof total);

//console.log('Total:'total, typeof total);

var text = 'Javascript é "super" facil';
console.log(text);
//atencao as aspas!

var nota = 10;
var aluno = 'Juca';
var texto = `A nota do ${aluno} foi ${nota}.`;
console.log(texto);
//crase
//se tiver so string imprime so entre aspas

//definir aspas DUPLAS ou SIMPLES

var resposta = "It's study time";

//os outros operadores sao iguais
var numero = 2e10;
//ou 2*(10**10)
//2 x 10 elevado a 10

var numero2 = 2e3;
//2 x 10 elevado a 3

var conta = 2 * 5 + 3;
//se quiser que muda a ordem coloca parenteses -> soma primeiro

//converter int float em int
var numero1 = 10.23;
console.log(Number.parseInt(numero1));
//escolhe a qdd de casas decimais
console.log(numero1.toFixed(1));

var num1 = 10;
var num2 = num1++;
//pos incremento
//numero2=num1
//numero=num1+1

var num2 = ++num1;
//pre incremento
//num1=num1+1
//num2=num1

//pre incremento:
//Primeiro soma +1 e depois operacao
//var a=10, b=++a;
//a=a+1=11;
//var b=a=11;

//b=++a*2 
//a=a+1
//b=a
//a=11 e b=22

//pos incremento:
//Primeiro operacao e depois soma +1 
//var a=10, b=a++;
//var b=a=10;
//a=a+1=11;

//var a=10; a=10
//var b=a++; b=10
//a=11
//console.log(a++, b--);
//a=11. b=9 ...

//string vira numero
//var texto="10"
//var numero=+texto+50;

//var numero=50
//numero+=60
//numero=numero+60

var cor = '';

if (cor) {
  console.log("tem cor");
}
else {
  console.log("nao tem cor");
}

if(('Gato' === 'gato') && (5 > 2)) {  
  console.log('Verdadeiro');
} else {  
  console.log('Falso');
}

var nota = 5;
var frequencia = 80;
var passou = ((frequencia >= 75) && (nota>6)) ? 'Passsou' : 'Não passou';  console.log(passou) // nao Passou
// melhor do que escrever com if

function imprimeAreaQuadrado(lado){
  console.log(lado*lado);
}
imprimeAreaQuadrado(4);

function imprimeAreaRetangulo(base, altura){
  var area = base*altura;
  console.log(`Area do retangulo: ${area.toFixed(2)}`);
}
imprimeAreaRetangulo(20, 3);

addEventListener('click', function() {
  console.log('Clicou');
});

//aula 22-08

var teste3 = (params) => {
  console.log(params);
} //funcao sem nome que recebe params como parametro 

var imc = (peso, altura) => {
  return peso/(altura**2);
}

console.log(imc(60, 1.60));
//se nao existir a variavel no escopo da funcao ela busca no pai (acima)

var perimetro = (ladoQuadrado) => {
  return ladoQuadrado*4;
}

console.log(`O perímetro do quadrado é de ${perimetro(2)} m`);

var nomeCompleto = (nome,sobrenome) => {
  return `${nome} ${sobrenome}`;
}

console.log(nomeCompleto('Jessica','Laine'));

document.addEventListener('scroll', () => {
  console.log(nomeCompleto('Hugo', 'Silva'));
});
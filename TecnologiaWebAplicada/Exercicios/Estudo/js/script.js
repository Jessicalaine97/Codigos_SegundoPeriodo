var nome = "Joãozinho";
var resultado;
function somar(a, b) {
    return a + b;
}
resultado = somar(2, 4);
console.log(nome);
console.log(resultado);
//resultado 6

var idade = 28;
const prof = "Estudante";
const frequente = true;
console.log(prof, frequente);
//const nao pode ter um valor alterado, var e let podem!

/*Comentarios para faixas de codigos*/

/*TIPOS DE VARIAVEIS:
var nome="Joãozinho"; //string
var idade = 28; //number
var frequente = true; //boolean
var time; //undefined
var comida=null; //vazio
var simbolo=Symbol() //simbolo -> objeto*/

/*VERIFICAR TIPO DE DADO:*/
console.log(typeof nome);
//imprime string

/*TEMPLATE STRING: CRASE*/
var pontos = 10;
var frase1 = `O aluno fez ${pontos} pontos.`;
console.log(frase1);

/*NUMEROS:
var idade=28;
var pi=3.14; //ponto para decimal
var exp=2e10; //20000000000*/

/*OPERADORES:
var soma = 100 + 50; //150
var soma1 = '100' + 50; //10050 -> SO SOMA A STRING CONCATENA
var subtracao = 100 - 50; //50
var mult = 100 * 2; //200
var div = 100 / 2; //5
var div1 = 'Comprei 10' // 2 -> NaN (not a number)
var resto = 14 % 5; //4 ou modulo
var exp = 2 ** 4 //16*/

/*A ORDEM DOS OPERADORES IMPORTA:
var total1=20+5*2; //30
var total2=10+10*2+20/2; //40
var total3=(10+10)*2; //40*/


/*INCRENTO E DECREMENTO (POS E PRE):

var num1=10;

var num2=num1++; // num1 = 11 , num2 = 10
//num2=num1
//num1=num1+1

var num2=++num1; // num1 = num2 = 11
//num1=num1+1
//num2=num1

var num2c=num1--; // num1 = 9 , num2 = 10
//num2=num1
//num1=num1-1

var num2d=--num1; // num1 = num2 = 9
//num1=num1-1
//num2=num1*/

/*+ e - (conversao em num):
var idade = '28';
+idade; //28(num)
-idade; //-28(num)*/

/*TRUE AND FALSE 
FALSE: false, 0, NaN, null, undefined, '', "", ``
TRUE: true, 1, ' ', 'batinha', -5, {}
*/

/*Operador negação (!)
if(!true) // false  
if(!1) // false  
if(!'') // true
if(!undefined) // true
if(!!' ') // true
if(!!'') // false
*/

/* == e ===
10 == '10'; // true
10 == 10; // true
10 === '10'; // false
10 === 10 // true 
*/

/* && and ||
&&: retorna o primeiro false que encontrar
||: retorna o primeiro true que encontrar 
*/

/*Operadores de atribuicao:
var x =5;
var y = 10;
x += y; // x = x + y (15)
x -= y; // x = x - y (-5)
x *= y; // x = x * y (50)
x /= y; // x = x / y (0.5)
x %= y; // x = x % y (0)
x **= y; // x = x ** y (9765625)*/

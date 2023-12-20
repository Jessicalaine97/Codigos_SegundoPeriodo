let paragrafos1 = document.getElementsByClassName('impar');

let paragrafos2 = document.querySelectorAll('.impar');

paragrafos2.forEach(element => {
    console.log(element)
});

/*g1:
let imagens = document.querySelectorAll('img'); //selecionando todas as tags img
undefined
imagens.forEach(Element => console.log(Element) )
 */

//selecionando o primeiro paragrafo:
let paragrafo = document.querySelector('p');
console.log(paragrafo.className);

console.log(paragrafo.classList);

const corpo = document.querySelector('body');
const botao = document.getElementById('modoEscuro');

function modoEscuro(){
   
    if(botao.innerText == "Modo Claro"){
        corpo.classList.remove('temaescuro');
        botao.innerText = "Modo Escuro";
    } else {
        corpo.classList.add('temaescuro');
        botao.innerText = "Modo Claro";
    }
}

function alterarModo(){

    const textosVemelhos=document.querySelectorAll('.texto-vermelho');

    if(textosVemelhos.length > 0){
        
    }
   
    const textosAzul = document.querySelectorAll('.texto-azul');
    textosAzul.forEach(texto => {
        texto.classList.replace('texto-azul', 'texto-vermelho');
    });

    corpo.classList.toggle('temaescuro');
}
//query selector sempre retorna o 1 que achar
// classList.toggle muda claro /escuro mais facil

const link = document.getElementById("LinkGoogle"); //ou querySelector
console.log(link);
console.log(link.attributes[0]); //0 -> href, 1 -> id ...
console.log(link.getAttribute('href'));
link.setAttribute('nomeAtributo', 'jessica'); //mudar o alt

/*Trazendo todas as imagens do globo.com
let imagens = document.querySelectorAll("img");
imagens.forEach(imagem => {
    console.log(imagem.getAttribute('src'));
});*/





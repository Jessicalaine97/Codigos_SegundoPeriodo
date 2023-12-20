//DOM
console.log(window);
console.log(document);

//ctrl shift p -> ipsum

let titulo=document.getElementById('titulo1');
titulo.innerText= "Novo titulo";
console.log(titulo);

let paragrafo=document.getElementById('paragrafo1');

let mariana = {
  quantidade: 10,
  conta(){
    let letra = '';
    let contagem = [];
    let i = 1;
    while ( i <= this.quantidade){
        contagem.push(` é ${i} `);
        letra += 
        `Mariana conta ${i} \n`+
        `Mariana conta ${i}: ${contagem}, é!\n`;
        letra += `Ana, viva a Mariana, viva a Mariana \n\n`;
        i++;
    };
    return(letra);
  }
};

paragrafo.innerText= mariana.conta();

//id -> unico
//p(tag) e div(classe) pode ter varios

let paragrafos = document.getElementsByTagName('p');
console.log(paragrafos);

//imprimindo os 3 paragrafos
let paragrafos=document.getElementsByTagName('p');

//imprimindo so a classe a 
let a=document.getElementsByName('a');

let divPrincipal=document.getElementsByTagName('div');

let todosParagrafos=document.querySelector('p');

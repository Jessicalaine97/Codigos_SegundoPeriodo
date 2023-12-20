/*let elefante = {
    quantidade : 10,
    titulo:'Um elefante incomoda muita gente',
    musica(){
        let musica = "1 elefante incomoda muita gente\n";
        let incomodam = [`incomodam `];
        for (let i = 2; i <= this.quantidade; i++){
            incomodam.push(`incomodam `);

            if ( i % 2 == 1 ){
                musica += `${i} elefantes incomodam muita gente\n`;           
            }else{
                musica += `${i} elefantes ${incomodam} muito mais! \n`;
            }
        }

        musica +=`\n`;

        for (let i = this.quantidade; i >= 2; i--){
            if ( i % 2 == 0 ){
                musica += `${i} elefantes incomodam muita gente\n`;           
            }else{
                musica += `${i} elefantes ${incomodam} muito menos! \n`;
            }
            incomodam.pop();
        }

        musica += "1 elefante incomoda muito menos\n";
        return musica;
    }
};


let titulo = document.getElementById('titulo');
titulo.innerText=elefante.titulo;

let paragrafo=document.getElementById('paragrafo');
paragrafo.innerText=elefante.musica();*/


DOM

/* retornar no console todas as imagens de um site*/ 
document.addEventListener(`click`, function() {

    var imagens = document.querySelectorAll('img');

    imagens.forEach(function(imagem) {
        console.log(imagem.src);
    });
});

/*retornar o primeiro h2 de um site*/ 

document.addEventListener(`click`, function() {
    var primeiroH2 = document.querySelector('h2');
    console.log(primeiroH2.textContent);
});

/*retornar o ultimo p de um site*/   
document.addEventListener(`click`, function() {
    const ultimoP = document.querySelector('body p:last-child');
    console.log(ultimoP.textContent);
});

/*retornar cada paragrafo de um site*/   
document.addEventListener(`click`, function() {
    var paragrafos = document.querySelectorAll('p');
    paragrafos.forEach(function(paragrafo) {
        console.log(paragrafo.textContent);
    });});
  
/*retornar o texto dos paragrafos de um site*/ 
document.addEventListener(`click`, function() {
    var paragrafos = document.querySelectorAll('p');
    var textoDosParagrafos = '';
    paragrafos.forEach(function(paragrafo) {
        textoDosParagrafos += paragrafo.textContent + '\n';
    });
    console.log(textoDosParagrafos);
});

/*Como corrigir o erro:*/ 
const imgs = document.querySelectorAll('img');
//faltava um parenteses aqui (calback tem 2 parametros)
imgs.forEach((item, index) => {
    console.log(item, index);
});

let i = 0;
//faltava outro parenteses aqui 
imgs.forEach(() => {
    console.log(i++);
});

let j = 0;
imgs.forEach(() => {
    console.log(j++);
});

/*adicionar a classe ativo a todos os itens do menu*/
document.addEventListener(`click`, function() {
    var itensDoMenu = document.querySelectorAll('.menu-item');
    itensDoMenu.forEach(function(item) {
        item.classList.add('ativo');
    });
});

/*remover a classe ativo a todos os itens do menu e deixar apenas no primeiro*/
document.addEventListener(`click`, function() {
    var itensDoMenu = document.querySelectorAll('.menu-item');
    itensDoMenu.forEach(function(item) {
        item.classList.remove('ativo');
    });
    if (itensDoMenu.length > 0) {
        itensDoMenu[0].classList.add('ativo');
    }
});

/*verificar se as imagens possuem o atributo alt*/
document.addEventListener(`click`, function() {
    var imagens = document.querySelectorAll('img');
    imagens.forEach(function(imagem) {
        if (imagem.alt != '') {
            console.log('A imagem possui o atributo alt.');
        }
    });
});

/*modificar o href do link externo ao menu*/
document.addEventListener(`click`, function() {
    var linkExterno = document.querySelector('.link-externo');
        linkExterno.href = 'novoLink.html';
});

/*quando o usuario clicar nos links internos do site, adiciona a classe ativo ao item clicado e remova dos demais itens caso eles possuam a mesma. previna o comportamento padrao desses links*/
 Não entendi :/

/*selecione todos os elementos do site começando a partit do body e ao clicar, mostre exatamnte quais elementos estao sendo clicados*/
document.addEventListener(`click`, function() {
    document.body.addEventListener('click', function(event) {
        var elementoClicado = event.target;
        console.log(elementoClicado);
    });
});

/*utilizar o metodo remove() para remover o elemento que esta sendo clicado*/
document.addEventListener(`click`, function() {
    document.body.addEventListener('click', function(event) {
        var elementoClicado = event.target;
        elementoClicado.remove();
    });
});

/*duplique um menu e adicione ele em copy*/
document.addEventListener(`click`, function() {
    var menuOriginal = document.querySelector('.menu');
    var menuCopy = menuOriginal.cloneNode(true);
    console.log(`${menuCopy}`);
});


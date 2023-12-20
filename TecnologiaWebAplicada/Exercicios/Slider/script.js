let imagens = [
'./assets/img/1.jpeg', 
'/assets/img/2.jpeg', 
'/assets/img/3.jpeg', 
'/assets/img/4.jpeg'];

let atual=0;

//inserir imagem via javascript
const slide = document.getElementById('slide');
slide.setAttribute('src', imagens[atual]);

const btnAvancar=document.getElementById('btnAvancar');
const btnVoltar=document.getElementById('btnVoltar');

btnAvancar.addEventListener('click', avancar);
btnVoltar.addEventListener('click', voltar);

function avancar(){
    atual++;
    if(atual == imagens.length)
    {
        atual = 0;
    }
    slide.setAttribute('src', imagens[atual]);
}

function voltar(){
    atual--;
    if(atual == -1)
    {
        atual = imagens.length-1;
    }
    slide.setAttribute('src', imagens[atual]);
}
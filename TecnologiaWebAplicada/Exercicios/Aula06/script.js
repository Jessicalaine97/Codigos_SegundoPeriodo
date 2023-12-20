const nome = document.getElementById('name');
const senha = document.getElementById('senha');
const cadastro = document.getElementById('cadastro');
const teste = document.getElementById('teste');

cadastro.addEventListener('submit', event =>{
    event.preventDefault();
    const psw=senha.value;
    if(psw.length < 6){
        alert(`${nome.value} a senha deve ter 6 digitos!`);
    }else{
        cadastro.submit();
    }
});

teste.addEventListener('click', event =>{
    event.preventDefault();
    teste.innerText="Clicou!";
})

const menu = document.querySelector('nav');
menu.innerHTML+='<p>Ultimo paragrafo</p>';

const paragrafo=document.querySelector('nav p');

const conteudo=document.getElementById('conteudo');
conteudo.appendChild(paragrafo);

const primeiroLi=document.querySelector('nav ul li');

const superior = primeiroLi.children[0];
const inferior = primeiroLi.children[2];

conteudo.appendChild(superior);
conteudo.appendChild(inferior);

const ultimoParagrafo = document.createElement('p');
ultimoParagrafo.innerText="Ultimo texto";

conteudo.appendChild(ultimoParagrafo);
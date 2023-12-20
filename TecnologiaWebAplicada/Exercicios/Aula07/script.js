const botaoAdd=document.getElementById('add');
const telefones = document.getElementById('telefones')

botaoAdd.addEventListener('click', event => {

    //console.log('Clicou!');
    const novoTelefone=document.createElement('input');
    novoTelefone.setAttribute('type', 'text');
    telefones.appendChild(novoTelefone);
    telefones.insertBefore(novoTelefone, botaoAdd);
})
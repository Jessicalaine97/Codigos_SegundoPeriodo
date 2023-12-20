let form = document.forms[0];

form.addEventListener(`submit`, (event)=>{
    event.preventDefault(); //nao deixar fazer o submit e no botao do href
    let nome = form.elements[`nome`].value;
    window.alert(`Nome: ${nome}`);
})

//criar botao
let btnLimpar=document.createElement(`button`);
btnLimpar.value="Limpar";
btnLimpar.innerText="Limpar";
form.appendChild(btnLimpar);

btnLimpar.addEventListener(`click`, () => {
    form.elements[`nome`].value='';
})

/*let formulario = document.forms[0];
let btnLimpar = document.createElement('button');
btnLimpar.value = "Limpar";
btnLimpar.innerText = "Limpar";
btnLimpar.setAttribute('type','button');
formulario.appendChild(btnLimpar);

btnLimpar.addEventListener('click', () => {

    let elementos = Array.from(formulario.elements);
    elementos.forEach(campo => {
        campo.value = '';
    });
});

formulario.addEventListener('submit', (event)=>{
    event.preventDefault();
   let nome = formulario.elements['nome'].value;
   window.alert(`Nome: ${nome}`);
}); */
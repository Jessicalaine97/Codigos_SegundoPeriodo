const botao=document.getElementById("botao");
let contador=0;
const resultado=document.createElement('h1');
botao.after(resultado); //insere o resultado depois de botao
resultado.innerText=`Contador: ${contador}`;

botao.addEventListener('click', () =>{
    contador++;
    console.log(contador);
    resultado.innerText=`Contador: ${contador}`;
})
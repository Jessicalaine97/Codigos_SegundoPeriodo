//heranca em javascript

//protected #
//private _

class Aluno {
    constructor(nome, matricula){
        this.nome=nome;
        this._matricula=matricula;
    };
    digaoi(){
        console.log(`Olá eu sou o(a) ${this.nome}`);
    }

    get matricula(){
        return `Matricula: ${this._matricula}`;
    }

    set matricula(value){
        this._matricula=value;
    }
}

//super construtor da classe pai

class Bolsista extends Aluno {
    constructor(nome, matricula, projeto){ 
        super(nome, matricula);
        this._projeto=projeto; /*protected*/ 
    }

    imprimeprojeto (){
        console.log(`Nome do projeto: ${this.projeto}`);
    }

    get projeto(){
        return this._projeto;
    }

    set projeto(value){
        this._projeto=value;
    }
}

const lucia = new Bolsista("Lucia", 456, "IA");
console.log(lucia);
console.log(lucia.projeto);
console.log(lucia.matricula);

//bolsista herda de aluno
Bolsista.prototype=Object.create(Aluno.prototype); 
//receita de criar bolsista é a msm de criar aluno (herança)

//melhorando o construtor
Object.defineProperty(Bolsista.prototype, 'constructor',{
    value: Bolsista,
    enumerable: false, /*se e enumeravel*/ 
    writable: true /*se e alteravel*/ 
});



const alfredo=new Aluno("Alfredo", "123"); //metodo para a classe
//alfredo.digaOi();

console.log(alfredo);

const juquinha = new Aluno("Juquinha", "123456");
console.log(juquinha);

const maquiazinha = new Aluno("Maquiazinha", "789");
console.log(maquiazinha);

const zezinho = Object.create(juquinha); //criando um objeto a partir de outro atraves de um prototipo
console.log(juquinha);
console.log(zezinho.nome);

console.log(Aluno.prototype);

const texto="Isso é um texto";
console.log(texto.charAt(0)); //acessa i


//exercicio

class Person{
    #name;
    constructor(first, last, age, gender, interestes){
        this.#name = {
        'first': first,
        'last' : last
        };
        
        this.age=age;
        this.gender=gender;
        this.interestes=interestes;
    };
    get name(){
        return `${this.#name.first} ${this.#name.last}`;
    }

    set name(value){
        this.name=value;
    }
}
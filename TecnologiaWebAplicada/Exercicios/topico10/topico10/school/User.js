let user = {
    name: "Luizinho",
    curso: "ADS"
}

function displayName(){
    console.log(user)
}

class User{
    
    constructor(name) {
        this.name = name
    }

    displayName() {
        console.log(this.name)
    }
}

export default User 
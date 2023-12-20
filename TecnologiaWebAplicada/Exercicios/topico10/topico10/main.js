import { sayHi } from "./sayHi.js"
import SchoolUser from "./school/User.js"
import SecurityUser from "./security/User.js"

let p1 = new SchoolUser ("Junin");
let p2 = new SchoolUser ("Fabin")

let ps1 = new SecurityUser ("Juuniiiinnnn ", 123456)

p1.displayName();
p2.displayName();

console.log(ps1.userName, ps1.password)

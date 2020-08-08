// Section 8 

//Template Literals

const greeting = `Hello World!`;

console.log(greeting);

const firstName = 'Douglas';
const lastName = 'Adams';
const age = 25;

console.log(`My name is ${firstName} ${lastName} age ${age}`);

// Default Parameters

function greet(name = 'Friend'){
    console.log(`Hello ${name}!`);
}

greet();
greet('Tom');

// Arrow Functions

const greeter = function(){
    console.log('Howdy');
}

const greeter2 = () => {
    console.log('Bonjour')
}

greeter2();

const multiply = (a,b) => {
    console.log((a*b)+b)
}

multiply(77,14)

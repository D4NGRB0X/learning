// Section 4

// Function Declaration

function reminder(){
    console.log('Keep coding');
}

reminder();

function distanceFunction(speed, time){
    console.log(speed*time);
}

distanceFunction(12,80)

// Function Expression (Anon function)

let distanceExpression = function(speed, time){console.log(speed * time);};

distanceExpression(80,3)

// Scope

let greet ='Hello';//global

function changeGreet(){
    let greet = 'Howdy'; //local
    console.log(greet);
}

console.log(greet);
changeGreet();
console.log(greet);

// Hoisting
/*  function declarations can be hoisetd
    function expressions cannot
    variable decaration and assginment must occur prior to use
    if not you will return undefined 
*/

distanceHoist(20, 80);

function distanceHoist(speed, time){
    console.log(speed*time);
}

let distanceHoistExpression = function (speed, time){
    console.log(speed * time);
}

distanceHoistExpression(12,24);

/*  Exercise 5
    BMI Calculation and Comparison
    BMI = weight / (height *height)
*/

//using variable assigments

let tomHeight = 1.74;
let tomWeight = 75.5;
let tomBmi = tomWeight/(tomHeight * tomHeight)
let adamHeight = 1.88;
let adamWeight = 81.2;
let adamBmi = adamWeight/(adamHeight * adamHeight)

//creating a class

class Person {
    constructor(height, weight){
        this.height = height
        this.weight = weight
        this.bmi = Math.round(weight/(height * height))
    }
}

let tom = new Person(1.74,75.5);
let adam = new Person(1.88,81.2);

if(adam.bmi>tom.bmi){
    console.log("Adam")
}
else {
    console.log("Tom")
}

/*  Exercise 6
    BMI Calculation Function
    BMI = weight / (height * height)
*/

function calcBMI(height,weight){
    return Math.round(weight/ (height * height));
}

let tomFuncBMI = calcBMI(tom.height,tom.weight);
let adamFuncBMI = calcBMI(adam.height,adam.weight)

console.log('Tom\'s BMI is', tomFuncBMI + '.');
console.log('Adam\'s BMI is', adamFuncBMI + '.');


/*  Exercise 7
    Tip Calculator:
    if bill less than $50 tip = 10%
    if bill greater than $50 but less than $100 tip = 15%
    if bill greater than $100 tip = 20%
    switch will not work here?
*/

let bills = [22,58,104]


function tipCalculator(cost){ //remeber D.R.Y.
    let tip;

        if(cost < 50){
            tip = cost * .1;
        }
        else if(cost >= 50 && cost <= 100){
            tip = cost * .15;
        }
        else {
            tip = cost * .2;
        }

    return tip
}

// using standard for loop

for(let bill = 0; bill < bills.length; bill++){
    console.log(tipCalculator(bills[bill]))
}

// using forEach builtin function

bills.forEach(function(bill){ console.log(tipCalculator(bill)); })

/*  Exercise 8
    score = 0-100
    A = 90-100
    B = 75-89
    C = 60-74
    D = 50-59
    F = 0-49
*/

let scores =[97,89,90,75,74,57,20,105,-7]

function gradeAssign(score){

    if(score >= 90 && score <= 100){return 'A'}
    else if(score >= 75 && score <= 89){return 'B'}
    else if(score >= 60 && score <= 74){return 'C'}
    else if(score >= 50 && score <= 59){return 'D'}
    else if(score >= 0 && score <= 49){return 'F'}
    else{return 'Out of bounds'}
}

scores.forEach(function(score){console.log(gradeAssign(score));})

/*  Exercise 9 and 10
    RNG range 1-6
    roll twice
    store in variable dice1 and dice2
    compare rolls and log higher
*/

let rollD6Expression = function(){return Math.floor(Math.random() * 6 + 1);}

for(let roll = 0; roll < 5; roll++){
    let die1 = rollD6();
    let die2 = rollD6Expression();
    
    if(die1 == die2){console.log('DRAW:', die1, '=', die2)}
    else if(die1 > die2){console.log('Die 1:', die1)}
    else{console.log('Die 2:', die2)}
}

function rollD6(){
    return Math.floor(Math.random() * 6 + 1);
}


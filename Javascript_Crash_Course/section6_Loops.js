// Section 6 Loops

for(let i = 1; i<=10; i++){
    console.log(i);
}
for(let i = 10; i>=1; i--){
    console.log(i);
}

// loop through array

let hobbies = ['parkour','climbing','coding','reading'];

for(let hobby=0; hobby<hobbies.length; hobby++){

    console.log(hobbies[hobby])

}

// while loop

let i = 1;
while (i <= 10){
    console.log(i);
    i++;
}

/*  Exercise 12
    FizzBuzz
    log 1 - 100
    if number is divisible by 3 log Fizz
    if number is divisible by 5 log Buzz
    if number is divisible by 3 & 5 log FizBuzz
*/

let number = 1
while(number <= 20){

    if(number % 3 === 0 && number % 5 === 0){
        console.log('Fizzbuzz')
    }
    else if(number % 3 === 0){
        console.log('fizz');
    }
    else if(number % 5 === 0){
        console.log('buzz');
    }
    else{
        console.log(number)
    }
    number++
}

/*  Exercise 13
    reverse array with for loop
*/

let sentence = ['backwards.', 'written', 'is', 'sentence', 'This',]

function reverseArray(arr){
    let reversedArray = []
    
    for(let item = 0; item < arr.length; item++){
        reversedArray.unshift(arr[item])
    }

    return reversedArray
}

console.log(reverseArray(sentence).join(' '))

//using reverse built in
console.log(sentence.reverse().join(' '))

/*  Exercise 14
    create function to compare arrays
    return new array containing items shared by both arrays
*/

var groceries1 = ['bananas', 'apples', 'oranges', 'pears', 'mangoes', 'watermelons', 'grapes'];
var groceries2 = ['watermelon', 'peaches', 'guava', 'lemons', 'apples', 'apricots', 'oranges'];

// course solution using nested for loops

function matchItem(arr1, arr2){
    let match = [];

    for(let item1 = 0; item1 < arr1.length; item1++){
        for(let item2 = 0; item2 < arr2.length; item2++){
            if (arr1[item1] === arr2[item2]){
                match.push(arr1[item1])
            }
        }
    }
    return match;
}

// using for loop and include built in

function arrCompare(arr1, arr2){
    let sharedItems = [];
    for(let item = 0; item<arr1.length; item++){
        if(arr2.includes(arr1[item])){
            sharedItems.push(arr1[item]);
        }
    }
    return sharedItems;
}    
console.log(arrCompare(groceries1,groceries2));
console.log(matchItem(groceries1,groceries2));

/*  Exercise 15
    create a loop that counts down from 20 stopping at 1
    log to console number and if it is odd or even
*/

let countDown = 20;
while (countDown >= 1){
    if(countDown % 2 === 0){
        console.log(countDown, 'is even')
    }
    else{
        console.log(countDown, 'is odd')
    }
    countDown--
}

for(let num = 20; num >= 1; num--){

    if(num % 2 === 0){
        console.log(num.toString(), 'is even')
    }
    else{
        console.log(num.toString(), 'is odd')
    }
}
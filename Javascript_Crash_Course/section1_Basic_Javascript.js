// Section 1
let things = [
    'Javascript is the best coding Language in the world',
    'Javascript, HTML, and CSS are ipmortant for Web development',
    'Coding can solve problems'];

things.forEach(function(thing){console.log(thing)})

let hobby1 = 'parkour';
let hobby2 = 'climbing';
let hobby3 = 'coding';
let hobby4 = 'cooking'

let hobbies = [hobby1, hobby2, hobby3, hobby4];
let lastHobby = hobbies.length -1

console.log('My favorite hobbies are ' + hobbies.slice(0,lastHobby).join(', ') + ', and ' + hobbies[lastHobby] + '.');
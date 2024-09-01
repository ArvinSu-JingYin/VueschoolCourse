let Pokemons = {
    amount() {
    },
    say(str) {
        console.log('Your Pokedex says: ', str)
    }
}

function howsMyCollection() {
    const size = Pokemons.amount()
    if(size === undefined) 
        return Pokemons.say('Ooops, not sure how many you have')
    if(size < 10) 
        return Pokemons.say('You only have a few, you need more')
    if(size < 50) 
        return Pokemons.say('You have quite some favorites. Keep going')
    return Pokemons.say('You have a great collection!')
}

const originalAmount = Pokemons.amount

function stubbedAmount(amount) {
    Pokemons.amount = () => amount
}

function havePokemons(amount){
    stubbedAmount(amount)
    howsMyCollection()
}

/*
In stub.js, the last line of the havePokemons function is console.log(havePokemons(5)), 
which prints the return value of the havePokemons function.
Since the howsMyCollection function does not have a specific return value, 
it defaults to returning undefined, so undefined will be displayed in the terminal.

Example:
console.log(havePokemons(5))
console.log(havePokemons(15))
console.log(havePokemons(55))
*/
havePokemons(5)
havePokemons(15)
havePokemons(55)

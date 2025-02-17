let args = []

const Permissions = {
    granted( ...params){
        args.push([ ...params ])
    }
}

class User{}

const user = new User()

function isUserAdmin(){
    return Permissions.granted(user, 'admin')
}
const test = function(){
    isUserAdmin()
    return JSON.stringify(args[0]) === JSON.stringify([user, 'admin'])
}

console.log(isUserAdmin())
console.log(args[0])
console.log('isUserAdmin is called with correct arguments: ', test())

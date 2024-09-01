class Session {
    constructor(){
        this.lastUpdate = Date.now()
    }

    touch(){
        this.lastUpdate
    }
}

// This function is used to monitor the invocation of a method on an object
function spyOn(obj, method) {

    // Save the original method
    const originalMethod = obj[method];

    // Create a spy object to record the number of calls and arguments
    const spy = {
        called: [],
        callCount: 0,
    };

    // Replace the original method with a new function
    obj[method] = function(...args) {

        // Record the arguments of the call
        spy.called.push(args);

        // Increment the call counter
        spy.callCount++;

        console.log(spy.called)
        
        // Call the original method and return its result
        return originalMethod.apply(this, args);
    };

    // Return the spy object
    return spy;
}

const dateSpy = spyOn(Date, 'now')

Date.now()

console.log(dateSpy.called.length > 0)
console.log(dateSpy.called.length)
console.log(dateSpy.called)

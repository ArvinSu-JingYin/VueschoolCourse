<template>
  <div>
    <h1>{{ name }}</h1>
      <input type="text" v-model="name" />
      <button @click="placeOrder">Place Order</button>

      <!-- type4 -->
      <!-- <button @click="removeWatcher">Remove Watcher</button> -->

      <!-- type5 -->
      <button @click="removeWatcher">Hide Cart Alert</button>

    <!-- <YummyMeal :name="name" :price="meal.price" @add-to-cart="addItemToCart"></YummyMeal> -->
    <YummyMeal v-for="meal in meals" :key="meal.name" :name="meal.name" :price="meal.price" @addToCart="addItemToCart"></YummyMeal>
  </div>
</template>

<script>
import YummyMeal from './components/YummyMeal.vue';
import { ref, reactive, watch } from 'vue';

export default {
  components: {
    YummyMeal
  },
  setup() {
    const name = ref('The Snazzy Burger')
    const meal = reactive({ name: 'Hamburger', price: 10.99 })
    const placeOrder = () => alert('Your order has been placed!')

    // const addItemToCart = (item) => alert(`${item} added to cart!`)

    // type2 : to use in watch
    /*The immediate: true option makes the watcher callback execute immediately after the watcher is created.*/
    // watch(name, (newName, oldName) => console.log(`name has changed from ${oldName} to ${newName}`), { immediate: true });

    // type3 : to use in watch
    const meals = reactive([
      { name: 'Hamburger 🍔', price: 10.99 },
      { name: 'The Snazzy Burger 🍔', price: 15.99 },
      { name: 'The Big Boy Burger 🍔', price: 20.99 },
      { name: 'Fries 🍟', price: 2.99 },
      { name: 'Fizzy Drink 🥤', price: 1.99 },
      { name: 'Smoothie 🍹', price: 3.99 }
    ])

    const cart = reactive([]);
    const addItemToCart = (item) => cart.push(item);

    /* When watch(cart, (newCart, oldCart) => console.log(newCart, oldCart))
    This watch function is observing the 'cart' array. Whenever the 'cart' array changes, 
    the callback function will be executed. The callback function receives two arguments: 
    'newCart' and 'oldCart', which represent the new and old values of the 'cart' array respectively.
    The console.log statement inside the callback function will log the new and old values of the 'cart' array.
    This is useful for debugging or performing actions based on changes to the 'cart' array.
    The first argument to the watch function is a function that returns a shallow copy of the 'cart' array.
    This ensures that the watch function is triggered whenever the contents of the 'cart' array change.
    The second argument is the callback function that will be executed when the 'cart' array changes.

    Use would be the same as the above code but with a ref:
    const cart = ref([]);
    watch( () => [...cart.value], (newCart, oldCart) => console.log(newCart, oldCart));
    */
    // watch(
    //   () => [...cart],
    //   (newCart, oldCart) => console.log(newCart, oldCart)
    // );


    /*When watch( cart,(newCart, oldCart) => console.log(newCart, oldCart));
    This watch function is observing the 'cart' array. Whenever the 'cart' array changes,
    the callback function will be executed. The callback function receives two arguments:
    'newCart' and 'oldCart', which represent the new and old values of the 'cart' array respectively.
    The console.log statement inside the callback function will log the new and old values of the 'cart' array.
    This is useful for debugging or performing actions based on changes to the 'cart' array.
    
    sample code :
    watch(
      cart,
      (newCart, oldCart) => console.log(newCart, oldCart)
    );

    Use would be the same as the above code but with a ref:
    const cart = ref([]);
    watch(cart.value, (newCart, oldCart) => console.log(newCart, oldCart));
    */

    // type4 : to use in watch
    // const removeWatcher = watch(
    //   [name, () => [...cart]],
    //   (newCart, oldCart) => console.log(newCart, oldCart)
    // );

    // type5 : to use in watch
    const removeWatcher = watch(
      () => [...cart],
      (newCart) => alert(newCart.join('\n'))
    );

    return {
      meal,
      meals,
      name,
      placeOrder,
      addItemToCart,
      cart,
      removeWatcher
    }
  },

  // type1 : to use in watch
  // watch: {
  //   name(newName, oldName) {
  //     console.log(`name has changed from ${oldName} to ${newName}`)
  //   }
  // }
}
</script>

<style scoped>
header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>

<template>
  <div>
    <h1>{{ name }}</h1>
    <!-- This error occurs because you are binding a string to v-model instead of a ref. In Vue 3,
      the object bound to v-model should be a ref or a reactive variable. 
      You should bind directly to name instead of name.value. -->
    <input type="text" v-model="name" />
    <button @click="placeOrder">Place Order</button>
    <!-- type1 -->
    <YummyMeal name="The Snazzy Burger 🍔" :price="5" @add-to-cart="addToCart"></YummyMeal>
    <!-- type2 -->
    <YummyMeal :name="meal.name" :price="meal.price" @add-to-cart="addToCart"></YummyMeal>
  </div>
</template>

<script>
import YummyMeal from './components/YummyMeal.vue'
import { ref, reactive } from 'vue'

export default {
  components: {
    YummyMeal
  },
  setup() {
    /*
    Note:
    you can also use `name = 'Hello from the setup function'`
    `const name = ref('The Snazzy Burger')`,
     but name would'nt change, it would be the same as 'The Snazzy Burger'.
    
    when you use 
    `let name = 'The Snazzy Burger'`
    `name = 'Hello from the setup function'`,
    name would change to 'Hello from the setup function'.

    it's better to use const and ref to change the value, prevent bugs.
    */
    const name = ref('The Snazzy Burger')
    name.value = 'Hello from the setup function'

    const meal = ref({ name: 'Hamburger 🍔', price: 5 })
    console.log('ref', meal.value.name)

    const meal2 = reactive({ name2: 'Hamburger2 🍔🍔', price2: 5 })
    console.log('reactive', meal2.name2)

    console.log('in setup', '--name.value--', name.value)

    //Type 1
    // function placeOrder() {
    //   console.log("Order placed");
    // }

    //Type 2
    const placeOrder = () => alert('Order placed')

    const addToCart = (item) => alert(`One ${item} added to  the cart`)

    return { name, placeOrder, addToCart, meal, meal2 }
  },
  created() {
    // this.name = 'Hello from the created hook'
    console.log('in created', '--this.name--', this.name)
  }
}
</script>


<style scoped>
header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
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

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
<template>
  <div>
    <h1>{{ name }}</h1>
    <input type="text" v-model="name" />
    <button @click="placeOrder">Place Order</button>
    <button @click="removeWatcher">Hide Cart Alert</button>

    <div>
      <label for="currencySymbol">Currency</label>
      <select id="currencySymbol" v-model="currencySymbol">
        <option value="$">Dollar ($)</option>
        <option value="€">Euro (€)</option>
        <option value="£">Pound (£)</option>
      </select>
    </div>
    <YummyMeal
      v-for="meal in meals"
      :key="meal.name"
      :name="meal.name"
      :price="meal.price"
      @addToCart="addItemToCart"
    ></YummyMeal>
  </div>
</template>

<script setup>
import YummyMeal from './components/YummyMeal.vue'
import { ref, reactive, watchEffect } from 'vue'

const currencySymbol = '$'
const name = ref('The Snazzy Burger')
const meal = reactive({ name: 'Hamburger', price: 10.99 })
const placeOrder = () => alert('Your order has been placed!')
const meals = reactive([
  { name: 'Hamburger 🍔', price: 10.99 },
  { name: 'The Snazzy Burger 🍔', price: 15.99 },
  { name: 'The Big Boy Burger 🍔', price: 20.99 },
  { name: 'Fries 🍟', price: 2.99 },
  { name: 'Fizzy Drink 🥤', price: 1.99 },
  { name: 'Smoothie 🍹', price: 3.99 }
])

const cart = reactive([])
const addItemToCart = (item) => cart.push(item)

const removeWatcher = watchEffect(() => alert(cart.join('\n')))
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

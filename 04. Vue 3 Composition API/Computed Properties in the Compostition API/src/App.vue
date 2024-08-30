<template>
  <div>
    <h1>{{ name }}</h1>
    <div>
      <input type="text" v-model="name" />
    </div>
    <YummyMeal :name="meal.name" :price="meal.price"></YummyMeal>
  </div>
</template>

<script>
import YummyMeal from './components/YummyMeal.vue'
import { ref } from 'vue'

export default {
  components: {
    YummyMeal
  },
  setup() {
    const name = ref('The Snazzy Burger')
    const meal = ref({
      name: 'The Snazzy Burger 🍔',
      price: 10.99
    })

    return {
      name,
      meal
    }
  }
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

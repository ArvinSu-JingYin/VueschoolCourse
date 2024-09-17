<script setup>
import TheHeader from "@/components/TheHeader.vue";
import ProductCard from "@/components/ProductCard.vue";
import { useProductStore } from "@/stores/ProductStore";
import { useCartStore } from "@/stores/CartStore";

//type 1 :
//import products from "@/data/products.json";
// const productStore = useProductStore();
// const cartStore = useCartStore();
// productStore.fill();

// const addToCart = (count, product) => {
//   count = parseInt(count);
//   cartStore.$patch((state) => {
//     for (let index = 0; index < count; index++) {
//       state.items.push(product);
//     }
//   });
// };
//type 2 :
//import { storeToRefs } from "pinia";
//const { products } = storeToRefs(productStore);

//type 3 :
const productStore = useProductStore();
const cartStore = useCartStore();
productStore.fill();
</script>

<template>
  <div class="container">
    <TheHeader />
    <ul class="sm:flex flex-wrap lg:flex-nowrap gap-5">
      <!-- type 1 : -->
      <!-- <ProductCard
        v-for="product in productStore.products"
        :key="product.name"
        :product="product"
        @addToCart="addToCart($event, product)"
      /> -->

      <!-- type 2 : -->
      <!-- <ProductCard
        v-for="product in products"
        :key="product.name"
        :product="product"
      /> -->

      <!-- type 3 : -->
      <ProductCard
        v-for="product in productStore.products"
        :key="product.name"
        :product="product"
        @addToCart="cartStore.addItems($event, product)"
      />
    </ul>
  </div>
</template>

<script setup>
import AppCard from "./components/AppCard.vue";
import AppButton from "./components/AppButton.vue";
import AppInput from "./components/AppInput.vue";
import TheMainNav from "./components/TheMainNav.vue";
</script>

<template>
  <div class="m-10">
    <TheMainNav />
    <form action="">
      <label for=""></label>
      <AppInput label="Username" />
      <AppButton>Submit</AppButton>
    </form>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <div class="m-10">
      <p
        class="first-letter:text-5xl selection:bg-red-500 selection:text-white"
      >
        Lorem ipsum dolor sit, amet consectetur adipisicing elit. Doloribus
        harum cupiditate, animi eos veritatis voluptas praesentium obcaecati
        debitis excepturi quae autem dolor optio, soluta magni repellat tempora
        ut voluptate ipsa!
      </p>
    </div>
    <div class="m-10">
      <p class="first-line:text-5xl">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Alias doloribus
        consectetur ipsum optio magni officiis adipisci perferendis minima
        dolorum aliquid laudantium mollitia corporis temporibus sint nesciunt,
        itaque sed. At, alias.
      </p>
    </div>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <div class="m-10">
      <ul class="list-disc marker:text-green-400 marker:text-2xl">
        <li>vue.js</li>
        <li>React.js</li>
        <li>Svelte.js</li>
        <li>Solid.js</li>
      </ul>
    </div>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <AppCard />
  </div>
</template>

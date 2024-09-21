<script setup>
//use composable
//const isLoggedIn = useIsLoggedIn();

//use pinia
import { useUser } from "@/stores/User";
const user = useUser();

definePageMeta({
  layout: "plain",
});

//use composable
// function login() {
//   isLoggedIn.value = true;
//   useRouter().push("/");
// }

//use pinia
function login() {
  user.isLoggedIn = true;
  useRouter().push("/");
}
</script>


<template>
  <form @submit.prevent="login">
    <h1>Login</h1>
    <label for="username">Username</label>

    <input type="text" id="username" />
    <label for="password">Password</label>
    <input type="password" id="password" />
    <button>Login</button>
  </form>
</template>
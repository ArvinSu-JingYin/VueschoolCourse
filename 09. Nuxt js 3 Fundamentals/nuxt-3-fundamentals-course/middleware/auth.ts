export default defineNuxtRouteMiddleware((to, from) => {
  const isLoggedIn = useState("isLoggedIn").value;

  if (!isLoggedIn) {
    return navigateTo("/login");

    //type message
    //return navigateTo("You are not allowed to visit /admin");
  }
});

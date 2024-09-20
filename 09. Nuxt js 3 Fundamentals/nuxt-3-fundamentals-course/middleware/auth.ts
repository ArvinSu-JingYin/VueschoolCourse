export default defineNuxtRouteMiddleware((to, from) => {
  const userIsLoggedIn = false;

  if (!userIsLoggedIn) {
    //type path
    return navigateTo("/login");

    //type message
    //return navigateTo("You are not allowed to visit /admin");
  }
});

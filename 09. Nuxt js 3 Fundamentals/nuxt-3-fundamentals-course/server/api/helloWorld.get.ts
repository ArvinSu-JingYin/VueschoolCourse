export default defineEventHandler((event) => {
  //type: html/text
  //return "Hello world";

  //type: json
  // return {
  //   message: "Hello helloWorld",
  // };

  //type: get method
  // return {
  //   message: event.method + "Hello Get",
  // };

  //type: async await
  // const body = await readBody(event);
  // return {
  //   message: "Hello Get",
  // };

  return {
    message: "Hello Get",
  };
});

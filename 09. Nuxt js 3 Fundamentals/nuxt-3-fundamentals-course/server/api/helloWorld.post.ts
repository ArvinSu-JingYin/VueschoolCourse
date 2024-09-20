export default defineEventHandler(async (event) => {
  //type: html/text
  //return 'Hello helloWorld'

  //type: json
  // return {
  //   message: "Hello helloWorld",
  // };

  const body = await readBody(event);
  return {
    message: body,
  };
});

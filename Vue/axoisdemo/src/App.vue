<template>
  <login></login>
  <logindomain></logindomain>
</template>

<script>
import Login from "./components/Login.vue";
import LoginResolveDomain from './components/LoginResolveDomain.vue';
export default {
  components: {
   login: Login,
   logindomain:LoginResolveDomain,
  },
  name: "App",
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>

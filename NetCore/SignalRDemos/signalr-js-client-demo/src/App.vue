<template>
  <div>
    <span>你好</span>
    <CDNSignalR></CDNSignalR>
  </div>
</template>

<script>
import CDNSignalR from "./components/CDNSignalR";
export default {
  name: "App",
  components: {
     CDNSignalR,
  },
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

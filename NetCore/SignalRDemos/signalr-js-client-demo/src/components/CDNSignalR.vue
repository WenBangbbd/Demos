<template>
  <div>
    <button @click="doConnectionBtnClick()">连接</button>
    <button @click="doSendBtnClick()">发送</button>
    <input type="text" v-model="user" />
    <input type="text" v-model="message" />
  </div>
</template>

<script>
import signalR from "@microsoft/signalr";
export default {
  data() {
    return {
      connection: null,
      user: "",
      message: "",
    };
  },
  methods: {
    async doConnectionBtnClick() {
      this.initSignalr();
      await this.start();
    },
    async doSendBtnClick() {
      await this.connection.invoke("SendMessage", this.user, this.message);
    },
    initSignalr() {
      this.connection = new signalR.HubConnectionBuilder()
        .withUrl("/chathub")
        .configureLogging(signalR.LogLevel.Information)
        .build();
      this.connection.on("ReceiveMessage", (user, message) => {
        console.log(user);
        console.log(message);
      });
    },
    async start() {
      try {
        await this.connection.start();
        console.log("SignalR Connected.");
      } catch (err) {
        console.log(err);
      }
    },
  },
};
</script>
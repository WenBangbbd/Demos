<template>
  <a-form
    layout="inline"
    :model="formState"
    @finish="handleFinish"
    @finishFailed="handleFinishFailed"
  >
    <a-form-item>
      <a-input v-model:value="formState.mobile" placeholder="mobile"> </a-input>
    </a-form-item>
    <a-form-item>
      <a-button
        type="primary"
        html-type="submit"
        :disabled="formState.mobile === ''"
      >
        Log in
      </a-button>
    </a-form-item>
  </a-form>
  <br />
  <button @click="action">按钮</button>
</template>
<script>
import { defineComponent, reactive,inject } from "vue";

export default defineComponent({
  setup() {
    const formState = reactive({
      mobile: "",
    });
    //获取全局变量
    const axios = inject("axios");
    const handleFinish = (values) => {
      console.log(values);
      axios
        .get("/api/Login/VertifyCode/12311")
        .then((values) => {
          console.log(values);
        })
        .catch((e) => {
          console.log(e);
        });
    };

    const handleFinishFailed = (errors) => {
      console.log(errors);
    };

    return {
      formState,
      handleFinish,
      handleFinishFailed,
    };
  },
  methods: {
    action() {
      let url = "api/Login/VertifyCode/12311";
      console.log("++++++++++++++++++");
      console.log(this.axios);
      this.axios
        .get(url)
        .then((values) => {
          console.log(values);
        })
        .catch((e) => {
          console.log(e);
        });
    },
  },
  components: {},
});
</script>
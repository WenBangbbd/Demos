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
</template>
<script>
import { defineComponent, reactive } from "vue";
import { getVertifyCode } from "../api/login";
export default defineComponent({
  setup() {
    const formState = reactive({
      mobile: "",
    });

    const handleFinish = (values) => {
      console.log(values);
      getVertifyCode(formState.mobile)
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

  components: {},
});
</script>
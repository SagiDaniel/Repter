<template>
  <form class="fizetes">
    <h3 class="center">Foglalás</h3>
    <hr>
    <label for="vezetek" class="form-label">Vezeték név</label>
    <br>
    <input type="text" pattern="^[a-zA-Z]+$" id="vezetek" class="form-control" v-model="vezetek" placeholder="Trap" required>
    <br>
    <label for="kereszt" class="form-label">Keresztév név</label><br>
    <input type="text" pattern="^[a-zA-Z]+$" class="form-control" id="kereszt" v-model="kereszt" placeholder="Pista" required>
    <br>
    <label for="validationCustom02" class="form-label">Email</label>
    <div class="input-group has-validation">
      <span class="input-group-text" id="inputGroupPrepend"><button type="button" class="btn btn-outline-dark"
        @click="email+='@'">@</button></span>
      <input type="email" class="form-control" id="email" placeholder="valakivagyok@gmail.com" v-model="email" required>
    </div>
    <br>
    <div class="form-check">
      <input class="form-check-input" type="checkbox" value="" id="invalidCheck" v-model="vasar" required>
      <label class="form-check-label" style="float:left;" for="invalidCheck">
        Fogadja el a feltételeket
      </label>
    </div>
    <div class="d-flex gap-3 justify-content-center">
      <button class="btn btn-success col-3" type="submit" @click="vasarlas()"  :disabled="!vasar" id="vasar">Vásárlás</button>
      <button class="btn btn-secondary col-3" type="button" @click="torles()">Mégse</button>
    </div>
  </form>
</template>

<script>
export default {
  methods: {
    vasarlas() {
      
      if (this.email != "" && this.vezetek!= "" && this.kereszt != "") {
        alert("Sikeres foglalás");
      }
      else {
        alert("Nincs kitöltve minden adat!");
      }
    }
    , torles() {
      alert("A kosár tartalma mostantól üres");
      for (const item of kosar) {
        kosar.pop();
      }
    }
  },
  data(){
    return{vasar:false,vezetek:"",kereszt:"",email:""}
  }
}
</script>
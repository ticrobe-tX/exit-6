<script>
import axios from 'axios';
import {
  MDBCard, MDBCardBody, MDBCardTitle, MDBCardText, MDBBtn,
  MDBTable,
  MDBBadge
} from "mdb-vue-ui-kit";
export default {
  components: {
    MDBCard,
    MDBCardBody,
    MDBCardTitle,
    MDBCardText,
    MDBTable,
    MDBBtn,
    MDBBadge
  },
  props: {

  },
  data() {
    return {
      orders:null
    }
  },
  mounted() {
    axios
      .get('http://localhost:5000/orders')
      .then(response => ( this.orders = response.data.orders ))
  }
};
console.log();
</script>

<template>
  <MDBCard style="min-width:auto;">
    <MDBCardBody>      
      <MDBCardTitle style="font-size:small;">The <strong style="font-weight: bold;font-style: italic;">Orders</strong>
        microApp</MDBCardTitle>
      <MDBTable class="align-middle mb-0 bg-white">
        <thead class="bg-light">
          <tr>
            <th>id</th>
            <th>name</th>
            <th>quantity</th>
            <th>date</th>
            <th>status</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="order in orders">
            <td>
              <div class="d-flex align-items-left">
                <div class="ms-3">
                  <p class="fw-bold mb-1">{{order.id}}</p>
                </div>
              </div>
            </td>
            <td>
              <div class="d-flex align-items-left">
                <div class="ms-3">
                  <p class="fw-bold mb-1">{{order.name}}</p>
                </div>
              </div>
            </td>
            <td>
              <div class="d-flex align-items-center">
                <div class="ms-3">
                  <p class="fw-bold mb-1">{{order.Quantity}}</p>
                </div>
              </div>
            </td>
            <td>
              <div class="d-flex align-items-left">
                <div class="ms-3">
                  <p class="fw-bold mb-1">{{order.Date}}</p>
                </div>
              </div>
            </td>
            <td>
              <div class="d-flex align-items-left">
                <div class="ms-3">
                  <p class="fw-bold mb-1">{{order.status}}</p>
                </div>
              </div>
            </td>
          </tr>
        </tbody>
      </MDBTable>
    </MDBCardBody>
    <MDBCardFooter style="padding:10px;font-size: 8px;font-weight:bold;color:red;">I have microUI in VueJS, microServer in Flask, microDatabase in JSON.</MDBCardFooter>
  </MDBCard>
</template>

<style scoped>
header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>

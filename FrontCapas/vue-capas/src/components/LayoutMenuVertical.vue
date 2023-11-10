<script setup>
    import Mapa from '../components/Map.vue'


</script>

<template>
    <v-card>
      <v-layout class="bordes-redondeados">
        <v-navigation-drawer permanent  class="fondoLeft bordes-redondeados">
            <!--Logo aplicacion-->
            <v-img src="src/assets/logoFondo.png" style="height: 125px;" align-left></v-img>
    
            <v-divider></v-divider>
            
            <v-list density="compact" nav>
                <v-list-item prepend-icon="fa-solid fa-house" title="Home" value="home"></v-list-item>
                <v-list-item prepend-icon="fa-solid fa-user" title="Mi cuenta" value="cuenta"></v-list-item>
            </v-list>

            <template v-slot:append>
                <div class="pa-2">
                    <v-btn block>
                        Salir
                    </v-btn>
                </div>
            </template>
        
            <v-main style="height: 250px;"></v-main>
        </v-navigation-drawer>

        <v-app-bar title="Application bar"></v-app-bar>

        <v-main class="d-flex align-center justify-center" style="min-height:fit-content;">
            <v-container>
                <Mapa/>
            </v-container>
        </v-main>
      </v-layout>
    </v-card>
    
</template>

<style>

.fondoLeft {
    background-color: #aaaab1;
}

.bordes-redondeados {
    border-radius: 10px;
    padding: 10px;
}

</style>

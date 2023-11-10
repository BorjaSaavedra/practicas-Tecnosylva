<template>
    <v-content>
        <v-container class="d-flex align-center justify-center fondo" style="height: 100vh" fluid>
            <VRow class="align-center justify-center">
                <v-col cols="12" sm="8" md="8">
                    <v-card class="elevation-12" style="height:fit-content;">
                    <v-window v-model="step">
                        <v-window-item :value="1">
                        <v-row>
                            <v-col cols="12" md="8">
                            <v-card-text class="mt-12">
                                <h1
                                class="text-center display-2 teal--text text--accent-3"
                                >Bienvenido a WorkLayouts!👋</h1>
                                <br>
                                <div class="text-center mt-4">
                                <v-btn class="mx-2" fab color="#aaaab1" outlined>
                                    <v-icon>fab fa-facebook-f</v-icon>
                                </v-btn>
                                <v-btn class="mx-2" fab color="#aaaab1" outlined>
                                    <v-icon>
                                    fab fa-google
                                    </v-icon>
                                </v-btn>
                                <v-btn class="mx-2" fab color="#aaaab1" outlined>
                                    <v-icon>fab fa-github</v-icon>
                                </v-btn>
                                </div>
                                <h4 class="text-center mt-4">Asegurate de estar registrado</h4>
                                <br>
                                <v-form>
                                <v-text-field
                                    label="Nombre de usuario"
                                    name="username"
                                    prepend-icon=  "fa fa-user"
                                    type="text"
                                    color="teal accent-3"
                                />

                                <v-text-field
                                    id="password"
                                    label="Contraseña"
                                    name="password"
                                    prepend-icon="fa fa-lock"
                                    type="password"
                                    color="teal accent-3"
                                />
                                </v-form>
                                <h3 class="text-center mt-4">¿Contraseña olvidada?</h3>
                            </v-card-text>
                            <div class="text-center mt-3">
                                <v-btn rounded color="#aaaab1" dark>Inicia Sesión</v-btn>
                            </div>
                            </v-col>
                            <v-col cols="12" md="4" class="teal accent-3" style="background-color:#F6CBF3;">
                            <v-card-text class="white--text mt-12">
                                <h1 class="text-center display-3">¿Primera vez aquí?</h1>
                                <br>
                                <h5
                                class="text-center"
                                >Introduce tus datos y entra en la aplicación</h5>
                            </v-card-text>
                            <div class="text-center">
                                <v-btn rounded outlined dark @click="step++">Registro</v-btn>
                            </div>
                            <div>
                                <v-img src="src/assets/personaje4.png" width="100%"></v-img>
                            </div>
                            </v-col>
                        </v-row>
                        </v-window-item>
                        <!--Ventana de registro-->
                        <v-window-item :value="2">
                        <v-row class="fill-height">
                            <v-col cols="12" md="4" class="teal accent-3" style="background-color:#F6CBF3;">
                            <v-card-text class="white--text mt-12">
                                <h1 class="text-center display-1">Bienvenido de vuelta!</h1>
                                <br>
                                <h5
                                class="text-center"
                                >Para acceder a tu cuenta personal, inicia sesión</h5>
                            </v-card-text>
                            <div class="text-center">
                                <v-btn rounded outlined dark @click="step--">Inicia Sesion</v-btn>
                            </div>
                            <div>
                                <v-img src="src/assets/personaje3.png" width="100%"></v-img>
                            </div>
                            </v-col>
                            <v-col cols="12" md="8">
                            <v-card-text class="mt-12">
                                <h1 class="text-center display-2 teal--text text--accent-3">Crea una Cuenta</h1>
                                <div class="text-center mt-4">
                                <v-btn class="mx-2" fab color="#aaaab1" outlined>
                                    <v-icon>fab fa-facebook-f</v-icon>
                                </v-btn>

                                <v-btn class="mx-2" fab color="#aaaab1" outlined>
                                    <v-icon>fab fa-google</v-icon>
                                </v-btn>
                                <v-btn class="mx-2" fab color="#aaaab1" outlined>
                                    <v-icon>fab fa-github</v-icon>
                                </v-btn>
                                </div>
                                <h4 class="text-center mt-4">Asegurate de que los datos sean correctos</h4>
                                <br>
                                <v-form>
                                <v-text-field
                                    label="Username"
                                    name="usernameRegistro"
                                    prepend-icon="fa fa-user"
                                    type="text"
                                    color="teal accent-3"
                                />
                                <v-text-field
                                    label="Email"
                                    name="Email"
                                    prepend-icon="fa fa-envelope"
                                    type="text"
                                    color="teal accent-3"
                                />

                                <v-text-field
                                    id="passwordReg"
                                    label="Contraseña"
                                    name="password"
                                    prepend-icon="fa fa-lock"
                                    type="password"
                                    color="teal accent-3"
                                />
                                </v-form>
                            </v-card-text>
                            <div class="text-center mt-n5">
                                <v-btn rounded color="#aaaab1" dark>Registro</v-btn>
                            </div>
                            <br>
                            </v-col>
                        </v-row>
                        </v-window-item>
                    </v-window>
                    </v-card>
                </v-col>
            </VRow>
        </v-container>
    </v-content>
</template>

<style>

.fondo{
    background-image: url('../assets/fondo3.jpeg');
    background-size:cover;
}

</style>

<script>
export default {
  data: () => ({
    step: 1
  }),
  props: {
    source: String
  }
};
</script>


//referencia do prompt
var bannerInstall;

if ('../../serviceWorker' in navigator){
    navigator.serviceWorker
        .register('sw.js')
        .then(function () {
            console.log('Service worker está registrado!');
        });
}

//evento disparado para instalar a aplicacao
window.addEventListener('beforeinstallprompt', function(event) {
    //console.log('beforeinstallprompt disparado...');
    //prevenindo a instalacao e guardando a referencia
    event.preventDefault();
    bannerInstall = event;
    return false;
  });

//  Controlando o banner de instalacao 
var btnBannerInstall = document.querySelector('#enable-banner-install');

function showBannerInstall(){
    if(bannerInstall){
        //exibindo o banner
        bannerInstall.prompt();
        //verificando a escolha do usuario
        bannerInstall.userChoice.then(function(choiceResult) {
            if (choiceResult.outcome === 'dismissed') {
                console.log('Usuario cancelou a instalacao');
              } else {
                console.log('Usuario aceitou a instalacao');
              }
        });
    }

    bannerInstall = null;
}
//clique do botao
btnBannerInstall.addEventListener('click', showBannerInstall);
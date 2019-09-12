import { browser, by, element } from 'protractor';

export class AppPage {
  navigateTo() {
    return browser.get('/user/login') as Promise<any>;
  }

  getTitleText() {
    return element(by.css('app-user h2')).getText() as Promise<string>;
  }

  getLoginButton() {
    return element(by.className('btn btn-lg btn-block'));
  }
}

import { FinalProjectTemplatePage } from './app.po';

describe('FinalProject App', function() {
  let page: FinalProjectTemplatePage;

  beforeEach(() => {
    page = new FinalProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

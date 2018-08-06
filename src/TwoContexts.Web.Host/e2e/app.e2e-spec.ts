import { TwoContextsTemplatePage } from './app.po';

describe('TwoContexts App', function() {
  let page: TwoContextsTemplatePage;

  beforeEach(() => {
    page = new TwoContextsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

import { ReactTemplatePage } from './app.po';

describe('React App', function() {
  let page: ReactTemplatePage;

  beforeEach(() => {
    page = new ReactTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

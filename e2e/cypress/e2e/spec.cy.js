describe('counter spec', () => {
  it('can increment', () => {
    cy.visit('/')
    cy.contains('Current Count: 0');
    cy.get('button').contains('Increment').click()
    cy.contains('Current Count: 1');
  });

  it('can decrement', () => {
    cy.visit('/')
    cy.contains('Current Count: 0');
    cy.get('button').contains('Decrement').click()
    cy.contains('Current Count: -1');
  });

  it('can increment and decrement', () => {
    cy.visit('/')
    cy.contains('Current Count: 0');
    cy.get('button').contains('Increment').click()
    cy.contains('Current Count: 1');
    cy.get('button').contains('Increment').click()
    cy.contains('Current Count: 2');
    cy.get('button').contains('Decrement').click()
    cy.contains('Current Count: 1');
  });
});
